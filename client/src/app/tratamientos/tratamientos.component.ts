import { Component, Injector } from '@angular/core';
import { TratamientosGenerated } from './tratamientos-generated.component';

@Component({
  selector: 'tratamientos',
  templateUrl: './tratamientos.component.html'
})
export class TratamientosComponent extends TratamientosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
