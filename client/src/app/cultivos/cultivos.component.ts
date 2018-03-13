import { Component, Injector } from '@angular/core';
import { CultivosGenerated } from './cultivos-generated.component';

@Component({
  selector: 'cultivos',
  templateUrl: './cultivos.component.html'
})
export class CultivosComponent extends CultivosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
