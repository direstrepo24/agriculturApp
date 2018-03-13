import { Component, Injector } from '@angular/core';
import { AddOfertaGenerated } from './add-oferta-generated.component';

@Component({
  selector: 'add-oferta',
  templateUrl: './add-oferta.component.html'
})
export class AddOfertaComponent extends AddOfertaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
