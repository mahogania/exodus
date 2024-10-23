import { ObjectWhereUniqueInput } from "./ObjectWhereUniqueInput";
import { ObjectUpdateInput } from "./ObjectUpdateInput";

export type UpdateObjectArgs = {
  where: ObjectWhereUniqueInput;
  data: ObjectUpdateInput;
};
