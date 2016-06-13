import {
  beforeEachProviders,
  describe,
  expect,
  it,
  inject
} from '@angular/core/testing';
import { CQRSng2AppComponent } from '../app/cqrsng2.component';

beforeEachProviders(() => [CQRSng2AppComponent]);

describe('App: CQRSng2', () => {
  it('should create the app',
      inject([CQRSng2AppComponent], (app: CQRSng2AppComponent) => {
    expect(app).toBeTruthy();
  }));

  it('should have as title \'cqrsng2 works!\'',
      inject([CQRSng2AppComponent], (app: CQRSng2AppComponent) => {
    expect(app.title).toEqual('cqrsng2 works!');
  }));
});
