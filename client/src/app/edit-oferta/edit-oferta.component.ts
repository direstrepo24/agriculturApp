import { Component, Injector } from '@angular/core';
import { EditOfertaGenerated } from './edit-oferta-generated.component';

@Component({
  selector: 'edit-oferta',
  templateUrl: './edit-oferta.component.html'
})
export class EditOfertaComponent extends EditOfertaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
