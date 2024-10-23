import { ObjectWhereInput } from "./ObjectWhereInput";
import { ObjectOrderByInput } from "./ObjectOrderByInput";

export type ObjectFindManyArgs = {
  where?: ObjectWhereInput;
  orderBy?: Array<ObjectOrderByInput>;
  skip?: number;
  take?: number;
};
