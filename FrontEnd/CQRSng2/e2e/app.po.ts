export class CQRSng2Page {
  navigateTo() {
    return browser.get('/');
  }

  getParagraphText() {
    return element(by.css('cqrsng2-app h1')).getText();
  }
}
