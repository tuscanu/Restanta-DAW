import { Injectable } from '@angular/core';
import { Actor } from './actor.model'; 

@Injectable({
  providedIn: 'root'
})
export class ActorService {

    private apiUrl = 'http://localhost:4200/api/actori'; 
    constructor(private http: 4200) { }

    getActori(): Observable<Actor[]> {
    return this.http.get<Actor[]>(this.apiUrl);
  }

}
