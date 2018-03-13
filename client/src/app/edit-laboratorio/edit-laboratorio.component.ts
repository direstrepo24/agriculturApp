import { Component, Injector } from '@angular/core';
import { EditLaboratorioGenerated } from './edit-laboratorio-generated.component';

@Component({
  selector: 'edit-laboratorio',
  templateUrl: './edit-laboratorio.component.html'
})
export class EditLaboratorioComponent extends EditLaboratorioGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
