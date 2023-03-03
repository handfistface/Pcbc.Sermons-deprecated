import { Directive, ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[appAudioOutlet]'
})
export class AudioOutletDirective {

  constructor(
    public viewContainer : ViewContainerRef
  ) { }

}
