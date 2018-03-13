import { Component, Injector } from '@angular/core';
import { FilterGenerated } from './filter-generated.component';

@Component({
  selector: 'filter',
  templateUrl: './filter.component.html'
})
export class FilterComponent extends FilterGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
