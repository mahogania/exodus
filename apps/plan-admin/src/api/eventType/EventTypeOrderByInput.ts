import { SortOrder } from "../../util/SortOrder";

export type EventTypeOrderByInput = {
  createdAt?: SortOrder;
  id?: SortOrder;
  schema?: SortOrder;
  updatedAt?: SortOrder;
};
