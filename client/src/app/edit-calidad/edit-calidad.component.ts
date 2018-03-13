import { Component, Injector } from '@angular/core';
import { EditCalidadGenerated } from './edit-calidad-generated.component';

@Component({
  selector: 'edit-calidad',
  templateUrl: './edit-calidad.component.html'
})
export class EditCalidadComponent extends EditCalidadGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
