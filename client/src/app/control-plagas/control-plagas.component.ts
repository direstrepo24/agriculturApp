import { Component, Injector } from '@angular/core';
import { ControlPlagasGenerated } from './control-plagas-generated.component';

@Component({
  selector: 'control-plagas',
  templateUrl: './control-plagas.component.html'
})
export class ControlPlagasComponent extends ControlPlagasGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
