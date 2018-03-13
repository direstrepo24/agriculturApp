import { Component, Injector } from '@angular/core';
import { AddTratamientoGenerated } from './add-tratamiento-generated.component';

@Component({
  selector: 'add-tratamiento',
  templateUrl: './add-tratamiento.component.html'
})
export class AddTratamientoComponent extends AddTratamientoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
