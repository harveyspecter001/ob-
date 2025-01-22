using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element
{
	// Token: 0x02000440 RID: 1088
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractiveUseErrorEvent : IMessage<InteractiveUseErrorEvent>, IMessage, IEquatable<InteractiveUseErrorEvent>, IDeepCloneable<InteractiveUseErrorEvent>, IBufferMessage
	{
		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x001D865C File Offset: 0x001D685C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractiveUseErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x001D866C File Offset: 0x001D686C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060033A6 RID: 13222 RVA: 0x001D867C File Offset: 0x001D687C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x001D868C File Offset: 0x001D688C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUseErrorEvent()
		{
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x001D869C File Offset: 0x001D689C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUseErrorEvent(InteractiveUseErrorEvent other)
		{
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x001D86AC File Offset: 0x001D68AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUseErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060033AA RID: 13226 RVA: 0x001D86BC File Offset: 0x001D68BC
		// (set) Token: 0x060033AB RID: 13227 RVA: 0x001D86CC File Offset: 0x001D68CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060033AC RID: 13228 RVA: 0x001D86DC File Offset: 0x001D68DC
		// (set) Token: 0x060033AD RID: 13229 RVA: 0x001D86EC File Offset: 0x001D68EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SkillInstanceUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x001D86FC File Offset: 0x001D68FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x001D870C File Offset: 0x001D690C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(InteractiveUseErrorEvent other)
		{
			return true;
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x001D871C File Offset: 0x001D691C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x001D872C File Offset: 0x001D692C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x001D873C File Offset: 0x001D693C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x001D874C File Offset: 0x001D694C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x001D875C File Offset: 0x001D695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x001D876C File Offset: 0x001D696C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(InteractiveUseErrorEvent other)
		{
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x001D877C File Offset: 0x001D697C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x001D878C File Offset: 0x001D698C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x001D879C File Offset: 0x001D699C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static InteractiveUseErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				InteractiveUseErrorEvent._parser = new MessageParser<InteractiveUseErrorEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x001D8868 File Offset: 0x001D6A68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tUIVBUOD6OagfntNWSoy()
		{
			return true;
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x001D8870 File Offset: 0x001D6A70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InteractiveUseErrorEvent gKa72LODLwqVORkFfuMm()
		{
			return null;
		}

		// Token: 0x04001211 RID: 4625
		private static readonly MessageParser<InteractiveUseErrorEvent> _parser;

		// Token: 0x04001212 RID: 4626
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001213 RID: 4627
		public const int ElementIdFieldNumber = 1;

		// Token: 0x04001214 RID: 4628
		private int elementId_;

		// Token: 0x04001215 RID: 4629
		public const int SkillInstanceUidFieldNumber = 2;

		// Token: 0x04001216 RID: 4630
		private int skillInstanceUid_;

		// Token: 0x04001217 RID: 4631
		internal static InteractiveUseErrorEvent kh4GYLODyQ4yx0p9rAYh;
	}
}
