import { Component, Injector } from '@angular/core';
import { AddLaboratorioGenerated } from './add-laboratorio-generated.component';

@Component({
  selector: 'add-laboratorio',
  templateUrl: './add-laboratorio.component.html'
})
export class AddLaboratorioComponent extends AddLaboratorioGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
