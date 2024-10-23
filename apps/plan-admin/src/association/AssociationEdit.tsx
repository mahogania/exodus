import * as React from "react";

import {
  Edit,
  SimpleForm,
  EditProps,
  ReferenceInput,
  SelectInput,
  ReferenceArrayInput,
  SelectArrayInput,
} from "react-admin";

import { AssociationTypeTitle } from "../associationType/AssociationTypeTitle";
import { ObjectTitle } from "../object/ObjectTitle";

export const AssociationEdit = (props: EditProps): React.ReactElement => {
  return (
    <Edit {...props}>
      <SimpleForm>
        <ReferenceInput
          source="associationType.id"
          reference="AssociationType"
          label="Association Type"
        >
          <SelectInput optionText={AssociationTypeTitle} />
        </ReferenceInput>
        <ReferenceArrayInput source="object" reference="Object">
          <SelectArrayInput
            optionText={ObjectTitle}
            parse={(value: any) => value && value.map((v: any) => ({ id: v }))}
            format={(value: any) => value && value.map((v: any) => v.id)}
          />
        </ReferenceArrayInput>
        <div />
      </SimpleForm>
    </Edit>
  );
};
