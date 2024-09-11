import { Injectable } from '@angular/core';
import { Price } from '../../models/Prices/price';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PriceService {

  private apiUrl = 'http://localhost:5120/api/Price';

  constructor(private http: HttpClient) { }

  public getPrices(): Observable<Price> {
    return this.http.get<Price>(this.apiUrl);
  }

  public create(apt: Price){
    this.http.post(this.apiUrl, apt).subscribe(
        data => {
            console.log(data)
        },
        err => {
            console.log(err)
        },
        () => {
            console.log("Completed")
        });
  }
  
}
