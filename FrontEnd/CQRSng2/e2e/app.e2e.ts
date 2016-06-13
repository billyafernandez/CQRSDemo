import { CQRSng2Page } from './app.po';

describe('cqrsng2 App', function() {
  let page: CQRSng2Page;

  beforeEach(() => {
    page = new CQRSng2Page();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('cqrsng2 works!');
  });
});
