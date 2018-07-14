import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/timeout';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  constructor(public navCtrl: NavController, public http: Http) {

  }

  StartLED() {
    let path = '{api endpoint}';
      let timeoutMS = 10000;
      this.http.get(path)
               .timeout(timeoutMS)
               .map(res => res.json())
               .subscribe(data => {
                  alert(data);
                },err => {
                  
                });
  }

  StopLED() {
    let path = '{api endpoint}';
      let timeoutMS = 10000;
      this.http.get(path)
               .timeout(timeoutMS)
               .map(res => res.json())
               .subscribe(data => {
                  alert(data);
                },err => {
                  
                });
  }
}
