import * as React from "react";
import {
  Edit,
  SimpleForm,
  EditProps,
  ReferenceArrayInput,
  SelectArrayInput,
} from "react-admin";
import { PropertyTitle } from "../property/PropertyTitle";
import { ObjectTypeTitle } from "../objectType/ObjectTypeTitle";

export const PropertyTypeEdit = (props: EditProps): React.ReactElement => {
  return (
    <Edit {...props}>
      <SimpleForm>
        <ReferenceArrayInput
          source="dynamicPropertyInstances"
          reference="Property"
        >
          <SelectArrayInput
            optionText={PropertyTitle}
            parse={(value: any) => value && value.map((v: any) => ({ id: v }))}
            format={(value: any) => value && value.map((v: any) => v.id)}
          />
        </ReferenceArrayInput>
        <ReferenceArrayInput source="objectTypes" reference="ObjectType">
          <SelectArrayInput
            optionText={ObjectTypeTitle}
            parse={(value: any) => value && value.map((v: any) => ({ id: v }))}
            format={(value: any) => value && value.map((v: any) => v.id)}
          />
        </ReferenceArrayInput>
        <div />
      </SimpleForm>
    </Edit>
  );
};
