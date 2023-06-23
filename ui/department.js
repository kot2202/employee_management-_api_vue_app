const department={template:`
<div>
<h1>Manage Departments</h1>

<button type="button"
class="btn btn-primary m-2 fload-end"
data-bs-toggle="modal"
data-bs-target="#exampleModal"
@click="addClick()">
 Add Department
</button>

<table class='table table-striped'>
<thead>
    <tr>
        <th>
            Department Id
        </th>
        <th>
            Department Name
        </th>
    </tr>
</thead>
<tbody>
    <tr v-for='d in departments'>
        <td>{{d.id}}</td>
        <td>{{d.name}}</td>
        <td>
            <button type='button' class='btn btn-light mr-1'><i class='bi bi-pencil-square'></i>
            </button>
        </td>
    </tr>
</tbody>
</table>

<div class="modal fade" id="exampleModal" tabindex="-1"
    aria-labelledby="exampleModalLabel" aria-hidden="true">
<div class="modal-dialog modal-lg modal-dialog-centered">
<div class="modal-content">
    <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">{{modalTitle}}</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal"
        aria-label="Close"></button>
    </div>
    <div class="modal-body">
        <div class="input-group mb-3">
            <span class="input-group-text">Department Name</span>
            <input type="text" class="form-control" v-model="name">
        </div>

        <button type="button" @click="createClick()"
        v-if="id==0" class="btn btn-primary">
        Create
        </button>
        <button type="button" @click="updateClick()"
        v-if="id!=0" class="btn btn-primary">
        Update
        </button>
    </div>
    
</div>
</div>

</div>
</div>
`,

data(){
    return{
        departments:[],
        modalTitle:"",
        name:"",
        id:0
    };
},

methods:{
    refreshData(){
        axios.get(variables.API_URL+"department")
        .then((response)=>{
            this.departments=response.data;
        });
    },
    addClick(){
        this.modalTitle="Add Department";
        this.id=0;
        this.name="";
    },
    createClick(){
        axios.post(variables.API_URL+"department",
        {
            name:this.name,
        })
        .then((response)=>{
            this.refreshData();
        });
    },
},
mounted:function(){
    this.refreshData();
},

}