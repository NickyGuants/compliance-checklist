import { Category, Priority, Status } from '../enums/enums';

export interface ComplianceTaskRequest {
  category: Category;
  description: string | undefined;
  dueDate: Date | undefined;
  priority: Priority;
  status: Status;
}