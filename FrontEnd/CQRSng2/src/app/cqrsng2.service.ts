import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Tweet } from './cqrsng2.tweet';
import { Observable }     from 'rxjs/Rx';

@Injectable()
export class CQRSApiService {

  private url: string = 'http://localhost:8080/api/Twitter';

  constructor (private http: Http) {}

  getTweets(): Observable<Tweet[]> {
    return this.http.get(this.url)
                        .map(this.extractData)
                        .catch(this.handleError);      
  }

  private extractData(res: Response) {
    let data = JSON.parse(res.json());
    return data || { };
  }
  private handleError (error: any) {
    // In a real world app, we might use a remote logging infrastructure
    // We'd also dig deeper into the error to get a better message
    let errMsg = (error.message) ? error.message :
      error.status ? `${error.status} - ${error.statusText}` : 'Server error';
    console.error(errMsg); // log to console instead
    return Observable.throw(errMsg);
  }
}