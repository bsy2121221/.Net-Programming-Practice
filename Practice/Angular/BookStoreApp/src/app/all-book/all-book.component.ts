import { Component, OnInit } from '@angular/core';
import { BookService } from '../book.service';

@Component({
  selector: 'app-all-book',
  templateUrl: './all-book.component.html',
  styleUrls: ['./all-book.component.css']
})
export class AllBookComponent implements OnInit {
  public books:any;

  constructor(private service: BookService) { }

  ngOnInit(): void {
    this.getBooks();
  }
  private getBooks():void{
    this.service.getBooks().subscribe(result=>{
      this.books=result;
    });
  }
}
