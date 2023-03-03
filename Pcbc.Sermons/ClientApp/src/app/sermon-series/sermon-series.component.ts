import { Component, Input } from "@angular/core";
import { AudioPlayerComponent } from "../audio-player/audio-player.component";
import { AudioFileViewModel } from "../view-models/audio-file-view-model";
import { SermonSeriesViewModel } from "../view-models/sermon-series-view-model";


@Component({
  selector: 'app-sermon-series-component',
  templateUrl: './sermon-series.component.html',
  styleUrls: ['./sermon-series.component.css']
})
export class SermonSeriesComponent {

  @Input() public sermonSeries: SermonSeriesViewModel;
  @Input() public audioComponentRef: AudioPlayerComponent;
  public toggleView: boolean = false;

  constructor() {
    this.sermonSeries = new SermonSeriesViewModel();
    this.audioComponentRef = new AudioPlayerComponent();
  }

  public toggle(): void {
    if (this.toggleView) {
      this.toggleView = false;
    } else {
      this.toggleView = true;
    }
  }

  public playAudioFile(audioFile: AudioFileViewModel) {
    this.audioComponentRef.playAudio(audioFile);
  }
}
