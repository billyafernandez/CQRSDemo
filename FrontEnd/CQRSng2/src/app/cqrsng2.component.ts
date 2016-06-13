import { Component } from '@angular/core';
import { MD_BUTTON_DIRECTIVES } from '@angular2-material/button';
import { MD_GRID_LIST_DIRECTIVES } from '@angular2-material/grid-list';
import { MdToolbar } from '@angular2-material/toolbar';
import { MdCheckbox } from '@angular2-material/checkbox';
import { CQRSApiService } from './cqrsng2.service';
import { Tweet } from './cqrsng2.tweet';

@Component({
  moduleId: module.id,
  selector: 'cqrsng2-app',
  templateUrl: 'cqrsng2.component.html',
  styleUrls: ['cqrsng2.component.css'],
  directives: [MD_BUTTON_DIRECTIVES, MD_GRID_LIST_DIRECTIVES, MdToolbar, MdCheckbox],
  providers: [CQRSApiService]  
})

export class CQRSng2AppComponent {

  title = 'CQRS Demo';
  tiles: any[] = [];  
  errorMessage: string;
  autoRefreshEnabled: any;

  constructor(private _service: CQRSApiService) { 
    this.autoRefresh();
  }

  getTweets() {
    this._service.getTweets()
                    .subscribe(
                     tweets => {
                       
                       tweets.forEach(tweet => {
                         
                          var tweetExists: boolean = false;
                          
                          for (var index = 0; index < this.tiles.length; index++) {
                              var element = this.tiles[index];
                              
                              if (element.url === tweet.media_url) {
                                tweetExists = true;
                              }                           
                          }

                          if (!tweetExists) {
                            var tile: any = { url: tweet.media_url };                                                    
                            this.tiles.unshift(tile);
                          }

                       });

                      },
                     error =>  this.errorMessage = <any>error);    
  }

 refresh() {
    this.getTweets();
  }

  autoRefresh() {
    setInterval(() => {
        if (this.autoRefreshEnabled && this.autoRefreshEnabled.checked) {
          this.refresh(); 
        }
      }, 3000);    
  }

  ngOnInit() {
    this.getTweets();
  }
}
