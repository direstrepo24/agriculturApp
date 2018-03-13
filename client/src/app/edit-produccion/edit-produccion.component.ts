import { Component, Injector } from '@angular/core';
import { EditProduccionGenerated } from './edit-produccion-generated.component';

@Component({
  selector: 'edit-produccion',
  templateUrl: './edit-produccion.component.html'
})
export class EditProduccionComponent extends EditProduccionGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
