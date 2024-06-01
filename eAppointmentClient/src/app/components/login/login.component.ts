import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  @ViewChild("password") password : ElementRef<HTMLInputElement> | undefined;

  constructor() { }

  ngOnInit(): void {
  
  }

  showHidePassword(){
    if(this.password ===undefined) return;

    if(this.password?.nativeElement.type ==="passwprd"){
        this.password.nativeElement.type ="text";
    }
    else {
        this.password.nativeElement.type ="password";
    }
  }

}
