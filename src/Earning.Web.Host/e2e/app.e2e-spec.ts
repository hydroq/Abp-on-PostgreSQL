import { EarningTemplatePage } from './app.po';

describe('Earning App', function() {
  let page: EarningTemplatePage;

  beforeEach(() => {
    page = new EarningTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
