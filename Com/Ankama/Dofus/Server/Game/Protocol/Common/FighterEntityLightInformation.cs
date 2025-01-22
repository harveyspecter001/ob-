using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A98 RID: 2712
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FighterEntityLightInformation : IMessage<FighterEntityLightInformation>, IMessage, IEquatable<FighterEntityLightInformation>, IDeepCloneable<FighterEntityLightInformation>, IBufferMessage
	{
		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x0600817D RID: 33149 RVA: 0x002613A8 File Offset: 0x0025F5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FighterEntityLightInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x0600817E RID: 33150 RVA: 0x002613B8 File Offset: 0x0025F5B8
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

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x0600817F RID: 33151 RVA: 0x002613C8 File Offset: 0x0025F5C8
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

		// Token: 0x06008180 RID: 33152 RVA: 0x002613D8 File Offset: 0x0025F5D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterEntityLightInformation()
		{
		}

		// Token: 0x06008181 RID: 33153 RVA: 0x002613E8 File Offset: 0x0025F5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterEntityLightInformation(FighterEntityLightInformation other)
		{
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x002613F8 File Offset: 0x0025F5F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterEntityLightInformation Clone()
		{
			return null;
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06008183 RID: 33155 RVA: 0x00261408 File Offset: 0x0025F608
		// (set) Token: 0x06008184 RID: 33156 RVA: 0x00261418 File Offset: 0x0025F618
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int EntityModelId
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

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06008185 RID: 33157 RVA: 0x00261428 File Offset: 0x0025F628
		// (set) Token: 0x06008186 RID: 33158 RVA: 0x00261438 File Offset: 0x0025F638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MasterId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x00261448 File Offset: 0x0025F648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x00261458 File Offset: 0x0025F658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FighterEntityLightInformation other)
		{
			return true;
		}

		// Token: 0x06008189 RID: 33161 RVA: 0x00261468 File Offset: 0x0025F668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x00261478 File Offset: 0x0025F678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x00261488 File Offset: 0x0025F688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x00261498 File Offset: 0x0025F698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x002614A8 File Offset: 0x0025F6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x002614B8 File Offset: 0x0025F6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FighterEntityLightInformation other)
		{
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x002614C8 File Offset: 0x0025F6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x002614D8 File Offset: 0x0025F6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x002614E8 File Offset: 0x0025F6E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FighterEntityLightInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FighterEntityLightInformation._parser = new MessageParser<FighterEntityLightInformation>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x002615CC File Offset: 0x0025F7CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SY0p1QJgCjd4Drw1NeMN()
		{
			return true;
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x002615D4 File Offset: 0x0025F7D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FighterEntityLightInformation tOnXFSJgDfR5eGTJDkHY()
		{
			return null;
		}

		// Token: 0x04002F1D RID: 12061
		private static readonly MessageParser<FighterEntityLightInformation> _parser;

		// Token: 0x04002F1E RID: 12062
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F1F RID: 12063
		public const int EntityModelIdFieldNumber = 1;

		// Token: 0x04002F20 RID: 12064
		private int entityModelId_;

		// Token: 0x04002F21 RID: 12065
		public const int MasterIdFieldNumber = 2;

		// Token: 0x04002F22 RID: 12066
		private long masterId_;

		// Token: 0x04002F23 RID: 12067
		internal static FighterEntityLightInformation TRcnaGJg0yhxF15X2NWl;
	}
}
