import { Component, Injector } from '@angular/core';
import { FotosGenerated } from './fotos-generated.component';

@Component({
  selector: 'fotos',
  templateUrl: './fotos.component.html'
})
export class FotosComponent extends FotosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
