import { PropertyTypeWhereUniqueInput } from "../propertyType/PropertyTypeWhereUniqueInput";
import { ObjectWhereUniqueInput } from "../object/ObjectWhereUniqueInput";
import { InputJsonValue } from "../../types";

export type PropertyUpdateInput = {
  dynamicProperty?: PropertyTypeWhereUniqueInput | null;
  object?: ObjectWhereUniqueInput | null;
  value?: InputJsonValue;
};
