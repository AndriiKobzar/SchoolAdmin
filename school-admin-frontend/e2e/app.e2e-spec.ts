import { SchoolAdminFrontendPage } from './app.po';

describe('school-admin-frontend App', () => {
  let page: SchoolAdminFrontendPage;

  beforeEach(() => {
    page = new SchoolAdminFrontendPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
