import { Component, Injector } from '@angular/core';
import { CategoriaGenerated } from './categoria-generated.component';

@Component({
  selector: 'categoria',
  templateUrl: './categoria.component.html'
})
export class CategoriaComponent extends CategoriaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
