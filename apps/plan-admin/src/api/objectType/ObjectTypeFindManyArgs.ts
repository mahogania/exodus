import { ObjectTypeWhereInput } from "./ObjectTypeWhereInput";
import { ObjectTypeOrderByInput } from "./ObjectTypeOrderByInput";

export type ObjectTypeFindManyArgs = {
  where?: ObjectTypeWhereInput;
  orderBy?: Array<ObjectTypeOrderByInput>;
  skip?: number;
  take?: number;
};
