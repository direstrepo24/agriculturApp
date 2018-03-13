import { Component, Injector } from '@angular/core';
import { AddEquipoGenerated } from './add-equipo-generated.component';

@Component({
  selector: 'add-equipo',
  templateUrl: './add-equipo.component.html'
})
export class AddEquipoComponent extends AddEquipoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
