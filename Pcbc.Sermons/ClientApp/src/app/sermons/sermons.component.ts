import { HttpClient } from '@angular/common/http';
import { AfterViewInit, Component, ComponentFactoryResolver, ComponentRef, Inject, OnDestroy, OnInit, ViewChild, ViewContainerRef } from '@angular/core';
import { Howl, Howler } from 'howler';
import { Subscription } from 'rxjs';
import { AudioOutletDirective } from '../audio-player/audio-outlet.directive';
import { AudioPlayerComponent } from '../audio-player/audio-player.component';
import { AudioFileViewModel } from '../view-models/audio-file-view-model';
import { SermonsViewModel } from '../view-models/sermons-view-model';

@Component({
  selector: 'app-sermons-component',
  templateUrl: './sermons.component.html',
  styleUrls: ['./sermons.component.css']
})

/*
 * This class draws all of the sermons
 */
export class SermonsComponent implements AfterViewInit, OnDestroy {

  public sermons: SermonsViewModel = new SermonsViewModel();
  public openSeries: string;

  @ViewChild(AudioOutletDirective, { static: true }) container !: AudioOutletDirective;
  public audioComponentRef !: ComponentRef<AudioPlayerComponent>;
  private lectureSubscription !: Subscription;

  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string
  ) {
    this.lectureSubscription = http.get<SermonsViewModel>(baseUrl + 'lecture/GetAllSermons').subscribe(result => {
      this.sermons = result;
    }, error => console.error(error));
    this.openSeries = "";
  }

  ngOnDestroy(): void {
    this.lectureSubscription.unsubscribe();
  }

  ngAfterViewInit(): void {
    const c = this.container.viewContainer;
    c.clear();
    this.audioComponentRef = c.createComponent <AudioPlayerComponent>(AudioPlayerComponent);
  }
}
