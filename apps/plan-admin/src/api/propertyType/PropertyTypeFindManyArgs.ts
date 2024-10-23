import { PropertyTypeWhereInput } from "./PropertyTypeWhereInput";
import { PropertyTypeOrderByInput } from "./PropertyTypeOrderByInput";

export type PropertyTypeFindManyArgs = {
  where?: PropertyTypeWhereInput;
  orderBy?: Array<PropertyTypeOrderByInput>;
  skip?: number;
  take?: number;
};
