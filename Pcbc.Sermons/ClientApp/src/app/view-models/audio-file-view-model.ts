
export class AudioFileViewModel {

  public fileName: string;
  public fullFileName: string;
  //the extension of the file like ".mp3"
  public fileExtension: string;
  //network path to the file being served, like "\sermons\Gospel of Mark\Servant of All.m4a"
  public networkPath: string;

  constructor() {
    this.fileName = "";
    this.fullFileName = "";
    this.fileExtension = "";
    this.networkPath = "";
  }
}
