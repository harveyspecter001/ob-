using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000415 RID: 1045
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectModifiedEvent : IMessage<ObjectModifiedEvent>, IMessage, IEquatable<ObjectModifiedEvent>, IDeepCloneable<ObjectModifiedEvent>, IBufferMessage
	{
		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x001D4F10 File Offset: 0x001D3110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectModifiedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x001D4F20 File Offset: 0x001D3120
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

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x0600315E RID: 12638 RVA: 0x001D4F30 File Offset: 0x001D3130
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

		// Token: 0x0600315F RID: 12639 RVA: 0x001D4F40 File Offset: 0x001D3140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectModifiedEvent()
		{
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x001D4F50 File Offset: 0x001D3150
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectModifiedEvent(ObjectModifiedEvent other)
		{
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x001D4F60 File Offset: 0x001D3160
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectModifiedEvent Clone()
		{
			return null;
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x001D4F70 File Offset: 0x001D3170
		// (set) Token: 0x06003163 RID: 12643 RVA: 0x001D4F80 File Offset: 0x001D3180
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectItemInventory Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x001D4F90 File Offset: 0x001D3190
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x001D4FA0 File Offset: 0x001D31A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectModifiedEvent other)
		{
			return true;
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x001D4FB0 File Offset: 0x001D31B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x001D4FC0 File Offset: 0x001D31C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x001D4FD0 File Offset: 0x001D31D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x001D4FE0 File Offset: 0x001D31E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x001D4FF0 File Offset: 0x001D31F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x001D5000 File Offset: 0x001D3200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectModifiedEvent other)
		{
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x001D5010 File Offset: 0x001D3210
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x001D5020 File Offset: 0x001D3220
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x001D5030 File Offset: 0x001D3230
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectModifiedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ObjectModifiedEvent._parser = new MessageParser<ObjectModifiedEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x001D5114 File Offset: 0x001D3314
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ncFZRnOC1wF974PKTusi()
		{
			return true;
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x001D511C File Offset: 0x001D331C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectModifiedEvent St27VLOCamg0ErtKEjBM()
		{
			return null;
		}

		// Token: 0x04001146 RID: 4422
		private static readonly MessageParser<ObjectModifiedEvent> _parser;

		// Token: 0x04001147 RID: 4423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001148 RID: 4424
		public const int ObjectFieldNumber = 1;

		// Token: 0x04001149 RID: 4425
		private ObjectItemInventory object_;

		// Token: 0x0400114A RID: 4426
		private static ObjectModifiedEvent Jaa0x0OCoZMA6UKcexoB;
	}
}
