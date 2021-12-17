import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BookService {
  private basePath='http://localhost:39518/api/Books'

  constructor(private http:HttpClient) { }
  public getBooks():Observable<any>{
    return this.http.get(this.basePath);
  }
}
