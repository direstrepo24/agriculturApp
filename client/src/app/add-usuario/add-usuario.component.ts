import { Component, Injector } from '@angular/core';
import { AddUsuarioGenerated } from './add-usuario-generated.component';

@Component({
  selector: 'add-usuario',
  templateUrl: './add-usuario.component.html'
})
export class AddUsuarioComponent extends AddUsuarioGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
