import { Component, Injector } from '@angular/core';
import { EditUsuarioGenerated } from './edit-usuario-generated.component';

@Component({
  selector: 'edit-usuario',
  templateUrl: './edit-usuario.component.html'
})
export class EditUsuarioComponent extends EditUsuarioGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
