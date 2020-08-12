const controller = new Controller(document)
controller.sendRequest();
controller.getNewsBySection();

var link = controller.apiLink;
controller.sendData(link);