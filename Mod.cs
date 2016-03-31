using System;
using System.Collections;
using System.Collections.Generic;
using spaar.ModLoader;
using TheGuysYouDespise;
using UnityEngine;

namespace Blocks
{
    public class 炮管Mod : BlockMod
    {
        public override Version Version { get { return new Version("1.0"); } }
        public override string Name { get { return "炮管Mod)"; } }
        public override string DisplayName { get { return "炮管模块Mod"; } }
        public override string BesiegeVersion { get { return "v0.27"; } }
        public override string Author { get { return "覅是"; } }
        protected Block 半管 = new Block()
            .ID(522)
            .BlockName("半炮管")
            .Obj(new List<Obj> { new Obj("半炮管.obj", //Obj
                                         "半炮管.png", //贴图
                                         new VisualOffset(new Vector3(1f, 1f, 1f), //Scale
                                                          new Vector3(0f, 0f, 0f), //Position
                                                          new Vector3(0f, 0f, 0f)))//Rotation
            })
            ///在UI下方的选模块时的模样
            .IconOffset(new Icon(new Vector3(1.30f, 1.30f, 1.30f),  //Scale
                                 new Vector3(-0.11f, -0.13f, 0.00f),  //Position
                                 new Vector3(45f, 45f, 45f))) //Rotation
            .Components(new Type[] { typeof(半炮管), })

            ///给搜索用的关键词
            .Properties(new BlockProperties().SearchKeywords(new string[] {
                                                             "Block",
                                                             "炮管",
                                                             "weapon",
                                             }))
            .Mass(1f)
            .ShowCollider(true)
            .CompoundCollider(new List<ColliderComposite> { new ColliderComposite(new Vector3(0.5f,0.1f,1.6f),new Vector3(0,0.6f,1f),new Vector3(0,0,0)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0.3f,0.5196f,1f),new Vector3(0,0,30)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0.5196f,0.3f,1f),new Vector3(0,0,60)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0.6f,0f,1f),new Vector3(0,0,90)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0.5196f,-0.3f,1f),new Vector3(0,0,120)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0.3f,-0.5196f,1f),new Vector3(0,0,150)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0f,-0.6f,1f),new Vector3(0,0,180)), 
            })
            .NeededResources(new List<NeededResource> {})
            .AddingPoints(new List<AddingPoint> {
                               (AddingPoint)new BasePoint(true, true)
                                                .Motionable(false,false,false)
                                                .SetStickyRadius(1f),
                               new AddingPoint(new Vector3(0,0f,1.5f),new Vector3(0,90,90),true)
            });
        protected Block 炮管 = new Block()
            .ID(523)
            .BlockName("炮管")
            .Obj(new List<Obj> { new Obj("炮管.obj", //Obj
                                         "炮管.png", //贴图
                                         new VisualOffset(new Vector3(1f, 1f, 1f), //Scale
                                                          new Vector3(0f, 0f, 0f), //Position
                                                          new Vector3(0f, 0f, 0f)))//Rotation
            })
            ///在UI下方的选模块时的模样
            .IconOffset(new Icon(new Vector3(1.30f, 1.30f, 1.30f),  //Scale
                                 new Vector3(-0.11f, -0.13f, 0.00f),  //Position
                                 new Vector3(45f, 45f, 45f))) //Rotation
            .Components(new Type[] { typeof(炮管), })

            ///给搜索用的关键词
            .Properties(new BlockProperties().SearchKeywords(new string[] {
                                                             "Block",
                                                             "炮管",
                                                             "weapon",
                                             }))
            .Mass(2f)
            .ShowCollider(true)
            .CompoundCollider(new List<ColliderComposite> {
                new ColliderComposite(new Vector3(0.5f,0.1f,2f),new Vector3(0,0.6f,1f),new Vector3(0,0,0)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0.3f,0.5196f,1f),new Vector3(0,0,30)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0.5196f,0.3f,1f),new Vector3(0,0,60)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0.6f,0f,1f),new Vector3(0,0,90)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0.5196f,-0.3f,1f),new Vector3(0,0,120)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(-0.3f,-0.5196f,1f),new Vector3(0,0,150)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(0f,-0.6f,1f),new Vector3(0,0,180)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(0.3f,-0.5196f,1f),new Vector3(0,0,210)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(0.5196f,-0.3f,1f),new Vector3(0,0,240)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(0.6f,0,1f),new Vector3(0,0,270)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(0.5196f,0.3f,1f),new Vector3(0,0,300)),
                new ColliderComposite(new Vector3(0.4f,0.1f,2f),new Vector3(0.3f,0.5196f,1f),new Vector3(0,0,330)),
            })
            .NeededResources(new List<NeededResource> { })
            .AddingPoints(new List<AddingPoint> {
                               (AddingPoint)new BasePoint(true, true)
                                                .Motionable(false,false,false)
                                                .SetStickyRadius(1f),
                               new AddingPoint(new Vector3(0,0f,1.5f),new Vector3(0,90,90),true)
            });
        public override void OnLoad()
        {
            LoadBlock(半管);//加载该模块
            LoadBlock(炮管);//加载该模块
        }
        public override void OnUnload() { }
    }


    public class 炮管 : BlockScript
    { 
        

        protected virtual IEnumerator UpdateMapper()
        {
            if (BlockMapper.CurrentInstance == null)
                yield break;
            while (Input.GetMouseButton(0))
                yield return null;
            BlockMapper.CurrentInstance.Copy();
            BlockMapper.CurrentInstance.Paste();
            yield break;
        }
        public override void OnSave(XDataHolder data)
        {
            SaveMapperValues(data);
        }
        public override void OnLoad(XDataHolder data)
        {
            LoadMapperValues(data);
            if (data.WasSimulationStarted) return;
        }

        protected override void OnSimulateStart()
        {
            foreach(Collider cocp in this.GetComponentsInChildren<Collider>())
            {
                cocp.material.dynamicFriction = 0;
                cocp.material.staticFriction = 0;
            }
            this.GetComponent<ConfigurableJoint>().breakForce = Mathf.Infinity;
            this.GetComponent<ConfigurableJoint>().breakTorque = Mathf.Infinity;
        }
        protected override void OnSimulateFixedUpdate()
        {
            this.GetComponent<Rigidbody>().mass = this.transform.localScale.x * this.transform.localScale.y * this.transform.localScale.z * 2;
        }
    }
    public class 半炮管 : BlockScript
    {


        protected virtual IEnumerator UpdateMapper()
        {
            if (BlockMapper.CurrentInstance == null)
                yield break;
            while (Input.GetMouseButton(0))
                yield return null;
            BlockMapper.CurrentInstance.Copy();
            BlockMapper.CurrentInstance.Paste();
            yield break;
        }
        public override void OnSave(XDataHolder data)
        {
            SaveMapperValues(data);
        }
        public override void OnLoad(XDataHolder data)
        {
            LoadMapperValues(data);
            if (data.WasSimulationStarted) return;
        }

        protected override void OnSimulateStart()
        {
            foreach (Collider cocp in this.GetComponentsInChildren<Collider>())
            {
                cocp.material.dynamicFriction = 0;
                cocp.material.staticFriction = 0;
            }
            this.GetComponent<ConfigurableJoint>().breakForce = Mathf.Infinity;
            this.GetComponent<ConfigurableJoint>().breakTorque = Mathf.Infinity;
        }
        protected override void OnSimulateFixedUpdate()
        {
            this.GetComponent<Rigidbody>().mass = this.transform.localScale.x * this.transform.localScale.y * this.transform.localScale.z;
        }
    }


}
