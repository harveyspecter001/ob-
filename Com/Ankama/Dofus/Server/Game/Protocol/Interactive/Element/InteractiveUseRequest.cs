using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element
{
	// Token: 0x0200043E RID: 1086
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractiveUseRequest : IMessage<InteractiveUseRequest>, IMessage, IEquatable<InteractiveUseRequest>, IDeepCloneable<InteractiveUseRequest>, IBufferMessage
	{
		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06003384 RID: 13188 RVA: 0x001D83EC File Offset: 0x001D65EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractiveUseRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06003385 RID: 13189 RVA: 0x001D83FC File Offset: 0x001D65FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x001D840C File Offset: 0x001D660C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x001D841C File Offset: 0x001D661C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUseRequest()
		{
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x001D842C File Offset: 0x001D662C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUseRequest(InteractiveUseRequest other)
		{
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x001D843C File Offset: 0x001D663C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveUseRequest Clone()
		{
			return null;
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x001D844C File Offset: 0x001D664C
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x001D845C File Offset: 0x001D665C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x001D846C File Offset: 0x001D666C
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x001D847C File Offset: 0x001D667C
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

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x001D848C File Offset: 0x001D668C
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x001D849C File Offset: 0x001D669C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpecificInstanceId
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

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x001D84AC File Offset: 0x001D66AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSpecificInstanceId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x001D84BC File Offset: 0x001D66BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearSpecificInstanceId()
		{
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x001D84CC File Offset: 0x001D66CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x001D84DC File Offset: 0x001D66DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(InteractiveUseRequest other)
		{
			return true;
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x001D84EC File Offset: 0x001D66EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x001D84FC File Offset: 0x001D66FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x001D850C File Offset: 0x001D670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x001D851C File Offset: 0x001D671C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x001D852C File Offset: 0x001D672C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x001D853C File Offset: 0x001D673C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(InteractiveUseRequest other)
		{
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x001D854C File Offset: 0x001D674C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x001D855C File Offset: 0x001D675C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x001D856C File Offset: 0x001D676C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static InteractiveUseRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					InteractiveUseRequest._parser = new MessageParser<InteractiveUseRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				InteractiveUseRequest.SpecificInstanceIdDefaultValue = 0;
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x001D864C File Offset: 0x001D684C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n1L9o4ODamW5PfCC3KIW()
		{
			return true;
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x001D8654 File Offset: 0x001D6854
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InteractiveUseRequest Hn7AYbOD5i3mt3HW1RdT()
		{
			return null;
		}

		// Token: 0x04001204 RID: 4612
		private static readonly MessageParser<InteractiveUseRequest> _parser;

		// Token: 0x04001205 RID: 4613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001206 RID: 4614
		private int _hasBits0;

		// Token: 0x04001207 RID: 4615
		public const int ElementIdFieldNumber = 1;

		// Token: 0x04001208 RID: 4616
		private int elementId_;

		// Token: 0x04001209 RID: 4617
		public const int SkillInstanceUidFieldNumber = 2;

		// Token: 0x0400120A RID: 4618
		private int skillInstanceUid_;

		// Token: 0x0400120B RID: 4619
		public const int SpecificInstanceIdFieldNumber = 3;

		// Token: 0x0400120C RID: 4620
		private static readonly int SpecificInstanceIdDefaultValue;

		// Token: 0x0400120D RID: 4621
		private int specificInstanceId_;

		// Token: 0x0400120E RID: 4622
		private static InteractiveUseRequest rsZOpoOD1xyOixicWO4S;
	}
}
