import { HttpClient } from '@angular/common/http';
import { Component, Inject, Input } from '@angular/core';
import { Howl, Howler } from 'howler';
import { AudioFileViewModel } from '../view-models/audio-file-view-model';
import { SermonsViewModel } from '../view-models/sermons-view-model';

@Component({
  selector: 'app-audio-player-component',
  templateUrl: './audio-player.component.html',
  styleUrls: ['./audio-player.component.css']
})
export class AudioPlayerComponent {

  //the audio file that is currently playing
  public audioFile !: AudioFileViewModel;

  public constructor(
  ) {
  }

  public playAudio(audioFile: AudioFileViewModel) {

    this.audioFile = audioFile;

    console.log("playing audio file " + audioFile.networkPath);

    //var sound = new Howl({
    //  src: audioFile.networkPath,
    //  html5: true
    //});
    //sound.play();
  }
}
