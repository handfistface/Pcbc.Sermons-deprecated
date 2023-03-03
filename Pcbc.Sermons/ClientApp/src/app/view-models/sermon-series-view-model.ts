import { AudioFileViewModel } from "./audio-file-view-model";

export class SermonSeriesViewModel {
  public sermonAudioFiles: AudioFileViewModel[];
  public name: string;
  public bannerNetworkPath: string;

  constructor() {
    this.sermonAudioFiles = [];
    this.name = "";
    this.bannerNetworkPath = "";
  }
}
