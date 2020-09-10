const controller = new Controller(document);
controller.sendRequest();
controller.getNewsBySection();
controller.getArticle();

const site = new Site(document);
site.changeToDarkTheme();
site.changeToLightTheme();