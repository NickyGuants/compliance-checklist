import { TestBed } from '@angular/core/testing';

import { ComplianceTaskService } from './compliance-task.service';

describe('ComplianceTaskService', () => {
  let service: ComplianceTaskService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ComplianceTaskService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
