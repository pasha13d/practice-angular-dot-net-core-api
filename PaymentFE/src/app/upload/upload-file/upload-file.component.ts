import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-upload-file',
  templateUrl: './upload-file.component.html',
  styleUrls: ['./upload-file.component.css']
})
export class UploadFileComponent implements OnInit {

  public message: string;
  public progress: number;

  @Output() public onUploadFinished = new EventEmitter();

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }  

  public uploadFile(files) {
    if(files.length === 0)
      return;
    let fileUpload = <File>files[0];

    const formData = new FormData();

    for(let file of files)
      formData.append("files", file);
console.log(files);
    this.http.post('https://localhost:44359/api/ImageUpload', formData, { reportProgress: true, observe: 'events'})
    .subscribe(event => {
      if(event.type === HttpEventType.UploadProgress) {
        this.progress = Math.round(100 * event.loaded / event.total);
      }
      else if(event.type === HttpEventType.Response) {
        this.message = 'Upload success.';
        this.onUploadFinished.emit(event.body);
      }
    })

  }

}
