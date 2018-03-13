import { Component, Injector } from '@angular/core';
import { EditTratamientoGenerated } from './edit-tratamiento-generated.component';

@Component({
  selector: 'edit-tratamiento',
  templateUrl: './edit-tratamiento.component.html'
})
export class EditTratamientoComponent extends EditTratamientoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
