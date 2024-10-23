import { PropertyTypeWhereUniqueInput } from "../propertyType/PropertyTypeWhereUniqueInput";
import { StringFilter } from "../../util/StringFilter";
import { ObjectWhereUniqueInput } from "../object/ObjectWhereUniqueInput";
import { JsonFilter } from "../../util/JsonFilter";

export type PropertyWhereInput = {
  dynamicProperty?: PropertyTypeWhereUniqueInput;
  id?: StringFilter;
  object?: ObjectWhereUniqueInput;
  value?: JsonFilter;
};
