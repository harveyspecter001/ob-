using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000222 RID: 546
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetSaveRequest : IMessage<PresetSaveRequest>, IMessage, IEquatable<PresetSaveRequest>, IDeepCloneable<PresetSaveRequest>, IBufferMessage
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x001AF35C File Offset: 0x001AD55C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PresetSaveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x001AF36C File Offset: 0x001AD56C
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

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x001AF37C File Offset: 0x001AD57C
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

		// Token: 0x06001978 RID: 6520 RVA: 0x001AF38C File Offset: 0x001AD58C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSaveRequest()
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x001AF39C File Offset: 0x001AD59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSaveRequest(PresetSaveRequest other)
		{
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x001AF3AC File Offset: 0x001AD5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSaveRequest Clone()
		{
			return null;
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x001AF3BC File Offset: 0x001AD5BC
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x001AF3D0 File Offset: 0x001AD5D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x001AF3E0 File Offset: 0x001AD5E0
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x001AF3F0 File Offset: 0x001AD5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Uuid
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

		// Token: 0x0600197F RID: 6527 RVA: 0x001AF400 File Offset: 0x001AD600
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x001AF410 File Offset: 0x001AD610
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetSaveRequest other)
		{
			return true;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x001AF420 File Offset: 0x001AD620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x001AF430 File Offset: 0x001AD630
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x001AF440 File Offset: 0x001AD640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x001AF450 File Offset: 0x001AD650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x001AF460 File Offset: 0x001AD660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x001AF470 File Offset: 0x001AD670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetSaveRequest other)
		{
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x001AF480 File Offset: 0x001AD680
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x001AF490 File Offset: 0x001AD690
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x001AF4A0 File Offset: 0x001AD6A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetSaveRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PresetSaveRequest._parser = new MessageParser<PresetSaveRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x001AF56C File Offset: 0x001AD76C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yGuHZ3Oa50qQJQPWd9q7()
		{
			return true;
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x001AF574 File Offset: 0x001AD774
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetSaveRequest O4k3IAOayZC3c35vjQjT()
		{
			return null;
		}

		// Token: 0x04000914 RID: 2324
		private static readonly MessageParser<PresetSaveRequest> _parser;

		// Token: 0x04000915 RID: 2325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000916 RID: 2326
		public const int TypeFieldNumber = 1;

		// Token: 0x04000917 RID: 2327
		private PresetType type_;

		// Token: 0x04000918 RID: 2328
		public const int UuidFieldNumber = 2;

		// Token: 0x04000919 RID: 2329
		private string uuid_;

		// Token: 0x0400091A RID: 2330
		private static PresetSaveRequest BovDvXOaafmwgGw53u02;
	}
}
