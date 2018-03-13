import { Component, Injector } from '@angular/core';
import { EditEquipoGenerated } from './edit-equipo-generated.component';

@Component({
  selector: 'edit-equipo',
  templateUrl: './edit-equipo.component.html'
})
export class EditEquipoComponent extends EditEquipoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
