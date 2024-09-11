import { Injectable } from '@angular/core';
import { Typology } from '../../models/typologeis/typology';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TypologyService {

  private apiUrl = 'http://localhost:5120/api/Typology';

  constructor(private http: HttpClient) { }

  public getTypologies(): Observable<Typology[]> {
    return this.http.get<Typology[]>(this.apiUrl);
  }

  public create(apt: Typology){
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
