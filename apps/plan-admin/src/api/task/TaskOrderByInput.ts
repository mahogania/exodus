import { SortOrder } from "../../util/SortOrder";

export type TaskOrderByInput = {
  actionId?: SortOrder;
  context?: SortOrder;
  createdAt?: SortOrder;
  id?: SortOrder;
  kind?: SortOrder;
  stepId?: SortOrder;
  updatedAt?: SortOrder;
};
